import express, { Request, Response } from 'express';
import cors from 'cors';
import dotenv from 'dotenv';
import { datas, BLOG_POSTS } from './data';
import { Property, Danisman, BlogPost } from './types';

// Environment variables
dotenv.config();

const app = express();
const PORT = process.env.PORT || 3000;

// CORS configuration for production - Render için daha esnek
const corsOptions = {
  origin: function (origin: string | undefined, callback: any) {
    // Allow requests with no origin (like mobile apps or curl requests)
    if (!origin) return callback(null, true);
    
    const allowedOrigins = [
      'https://your-frontend-domain.vercel.app', // Vercel domain'inizi buraya ekleyin
      'http://localhost:4200', // Local development
      'http://localhost:3000',  // Local development
      'https://localhost:4200', // Local development HTTPS
      'https://localhost:3000'  // Local development HTTPS
    ];
    
    if (allowedOrigins.indexOf(origin) !== -1) {
      callback(null, true);
    } else {
      console.log('CORS blocked origin:', origin);
      callback(null, true); // Geçici olarak tüm originlere izin ver
    }
  },
  credentials: true,
  optionsSuccessStatus: 200
};

app.use(cors(corsOptions));
app.use(express.json());

// Health check endpoint
app.get('/api/health', (req: Request, res: Response) => {
  res.json({ 
    status: 'OK', 
    timestamp: new Date().toISOString(),
    environment: process.env.NODE_ENV || 'development',
    port: PORT
  });
});

// Root endpoint
app.get('/', (req: Request, res: Response) => {
  res.json({ 
    message: 'Penta Nest Backend API',
    version: '1.0.0',
    endpoints: [
      '/api/health',
      '/api/ilanlar',
      '/api/blog',
      '/api/danismanlar'
    ]
  });
});

// Verileri sunucu başlangıcında bir kez işleyip bellekte tutma
const allProperties: Property[] = datas.flatMap(danisman => danisman.properties);

// Tüm ilanları döndüren API rotası
app.get('/api/ilanlar', (req: Request, res: Response) => {
  try {
    res.json(allProperties);
  } catch (error) {
    console.error('Error fetching properties:', error);
    res.status(500).json({ error: 'Internal server error' });
  }
});

// Belirli bir ilanı ID'sine göre döndüren API rotası
app.get('/api/ilanlar/:id', (req: Request, res: Response) => {
  try {
    const ilanId = req.params.id;
    console.log('Aranan ilan ID:', ilanId);
    
    const bulunanIlan = allProperties.find((p: Property) => p.id === ilanId);

    if (bulunanIlan) {
      res.json(bulunanIlan);
    } else {
      res.status(404).json({ error: 'İlan bulunamadı', id: ilanId });
    }
  } catch (error) {
    console.error('Error fetching property:', error);
    res.status(500).json({ error: 'Internal server error' });
  }
});

// Tüm blog yazılarını döndüren API rotası
app.get('/api/blog', (req: Request, res: Response) => {
  try {
    res.json(BLOG_POSTS);
  } catch (error) {
    console.error('Error fetching blog posts:', error);
    res.status(500).json({ error: 'Internal server error' });
  }
});

// Belirli bir blog yazısını slug'ına göre döndüren API rotası
app.get('/api/blog/:slug', (req: Request, res: Response) => {
  try {
    const blogSlug = req.params.slug;
    const blogPost = BLOG_POSTS.find((post: BlogPost) => post.slug === blogSlug);

    if (blogPost) {
      res.json(blogPost);
    } else {
      res.status(404).json({ error: 'Blog yazısı bulunamadı', slug: blogSlug });
    }
  } catch (error) {
    console.error('Error fetching blog post:', error);
    res.status(500).json({ error: 'Internal server error' });
  }
});

// Tüm danışmanları döndüren API rotası
app.get('/api/danismanlar', (req: Request, res: Response) => {
  try {
    res.json(datas);
  } catch (error) {
    console.error('Error fetching consultants:', error);
    res.status(500).json({ error: 'Internal server error' });
  }
});

// Belirli bir danışmanı URL'sine göre döndüren API rotası
app.get('/api/danismanlar/:url', (req: Request, res: Response) => {
  try {
    const danismanUrl = req.params.url;
    const danisman = datas.find((d: Danisman) => d.url === danismanUrl);

    if (danisman) {
      res.json(danisman);
    } else {
      res.status(404).json({ error: 'Danışman bulunamadı', url: danismanUrl });
    }
  } catch (error) {
    console.error('Error fetching consultant:', error);
    res.status(500).json({ error: 'Internal server error' });
  }
});

// 404 handler
app.use('*', (req: Request, res: Response) => {
  res.status(404).json({ 
    error: 'Endpoint bulunamadı',
    path: req.originalUrl,
    availableEndpoints: [
      '/',
      '/api/health',
      '/api/ilanlar',
      '/api/ilanlar/:id',
      '/api/blog',
      '/api/blog/:slug',
      '/api/danismanlar',
      '/api/danismanlar/:url'
    ]
  });
});

// Error handler
app.use((err: Error, req: Request, res: Response, next: any) => {
  console.error('Server error:', err);
  res.status(500).json({ 
    error: 'Sunucu hatası',
    message: process.env.NODE_ENV === 'production' ? 'Bir hata oluştu' : err.message
  });
});

app.listen(Number(PORT), '0.0.0.0', () => {
  console.log(`Backend sunucusu http://localhost:${PORT} adresinde çalışıyor.`);
  console.log(`Environment: ${process.env.NODE_ENV || 'development'}`);
  console.log(`CORS origins: configured`);
});