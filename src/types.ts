export interface Property {
  id: string;
  imageURL: string;
  title: string;
  price: number;
  location: string;
  emlakci: string;
  durum: string;
  konumLinki: string;
  aciklama: string;
  m2: number;
  odaSayisi: string | null;
  ilanTarihi: string;
  emlakTipi: string;
  binaYasi: number | null;
  bulunduguKat: string | null;
  katSayisi: number | null;
  isitma: string | null;
  banyoSayisi: string | null;
  mutfakTipi: string | null;
  balkon: string | null;
  asansor: string | null;
  otopark: string | null;
  esyali: string | null;
  kullanimDurumu: string | null;
  siteIcerisinde: string | null;
  krediyeUygun: string | null;
  tapuDurumu: string | null;
  kimden: string | null;
  takas: string | null;
  haritaUrl: string | null;
  imageCount: number;
}

export interface Danisman {
  foto: string;
  url: string;
  isim: string;
  hakkimda: string;
  telefon: string;
  mail: string;
  instagram: string;
  whatsapp: string;
  endeksa: string;
  properties: Property[];
}

export interface BlogPost {
  slug: string;
  author: string;
  date: string;
  title: string;
  image: string;
  snippet: string;
  fullContent: string;
}