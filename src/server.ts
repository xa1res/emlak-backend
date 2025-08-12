// CORS configuration for production
const corsOptions = {
  origin: function (origin: string | undefined, callback: any) {
    const allowedOrigins = [
      'https://penta-frontend-kappa.vercel.app', 
      'http://localhost:4200', 
      'http://localhost:3000',
      'https://localhost:4200',
      'https://localhost:3000'
    ];
    
    if (!origin || allowedOrigins.indexOf(origin) !== -1) {
      callback(null, true);
    } else {
      console.log('CORS blocked origin:', origin);
      callback(new Error('Not allowed by CORS')); // Güvenlik için hata döndürür
    }
  },
  credentials: true,
  optionsSuccessStatus: 200
};