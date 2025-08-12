# Emlak Backend API

Bu proje, Penta Nest emlak platformu için backend API servisidir.

## 🚀 Özellikler

- **İlan Yönetimi**: Emlak ilanlarını listeleme ve detay görüntüleme
- **Blog Sistemi**: Blog yazılarını yönetme
- **Danışman Bilgileri**: Emlak danışmanlarının bilgilerini sunma
- **RESTful API**: Modern REST API standartları
- **CORS Desteği**: Frontend entegrasyonu için CORS yapılandırması
- **TypeScript**: Tip güvenliği için TypeScript kullanımı

## 📋 Gereksinimler

- Node.js 18.x veya üzeri
- npm veya yarn

## 🛠️ Kurulum

### 1. Bağımlılıkları Yükleme

```bash
npm install
```

### 2. Environment Variables

`.env` dosyası oluşturun:

```bash
cp env.example .env
```

`.env` dosyasını düzenleyin:

```env
NODE_ENV=development
PORT=3000
FRONTEND_URL=http://localhost:4200
```

### 3. Development Server

```bash
npm run dev
```

### 4. Production Build

```bash
npm run build
npm start
```

## 🌐 API Endpoints

### Health Check
- `GET /api/health` - API durumu

### İlanlar
- `GET /api/ilanlar` - Tüm ilanları listele
- `GET /api/ilanlar/:id` - Belirli bir ilanı getir

### Blog
- `GET /api/blog` - Tüm blog yazılarını listele
- `GET /api/blog/:slug` - Belirli bir blog yazısını getir

### Danışmanlar
- `GET /api/danismanlar` - Tüm danışmanları listele
- `GET /api/danismanlar/:url` - Belirli bir danışmanı getir

## 🚀 Deployment

### Heroku Deployment

1. **Heroku CLI Kurulumu**
```bash
npm install -g heroku
```

2. **Heroku App Oluşturma**
```bash
heroku create your-app-name
```

3. **Environment Variables Ayarlama**
```bash
heroku config:set NODE_ENV=production
heroku config:set FRONTEND_URL=https://your-frontend-domain.vercel.app
```

4. **Deploy Etme**
```bash
git add .
git commit -m "Heroku deployment"
git push heroku main
```

5. **Build ve Start**
```bash
heroku run npm run build
heroku restart
```

### Vercel Frontend Entegrasyonu

Frontend'de API URL'ini güncelleyin:

```typescript
// environment.ts
export const environment = {
  production: true,
  apiUrl: 'https://your-heroku-app.herokuapp.com/api'
};
```

## 🔧 Scripts

- `npm run dev` - Development server başlat
- `npm run build` - TypeScript build
- `npm start` - Production server başlat
- `npm test` - Testleri çalıştır

## 📁 Proje Yapısı

```
src/
├── server.ts      # Ana server dosyası
├── types.ts       # TypeScript interface'leri
├── data.ts        # Mock data
└── index.ts       # Entry point
```

## 🔒 Güvenlik

- CORS yapılandırması
- Environment variables kullanımı
- Error handling
- Input validation

## 📝 Lisans

ISC License

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Commit yapın (`git commit -m 'Add amazing feature'`)
4. Push yapın (`git push origin feature/amazing-feature`)
5. Pull Request oluşturun

## 📞 İletişim

Penta Nest Team - [@pentanest](https://github.com/pentanest)
