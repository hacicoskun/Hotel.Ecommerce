using Hotel_Ecommerce.Repository.Interfaces;
using System;

namespace MevsimTazesi.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAnasayfaSlider AnasayfaSlider { get; }
        IBiziTakipEdin BiziTakipEdin { get; }
        IIletisim Iletisim { get; }
        ILoginUsers LoginUsers { get; }
        IOdaOzellikleri OdaOzellikleri { get; }
        IOdaOzellikListesi OdaOzellikListesi { get; }
        IOteller Oteller { get; }
        IOtelOzellikleri OtelOzellikleri { get; }
        IOtelOzellikListesi OtelOzellikListesi { get; }
        IOtelTeklifleri OtelTeklifleri { get; }
        ISiziArayalim SiziArayalim { get; }
        IYorumlar Yorumlar { get; }
        IOtelTemalari OtelTemalari { get; }
        IOtelTemalariListesi OtelTemalariListesi { get; }
         ISayfalarMenusu SayfalarMenusu { get; }
        int Save();
    }
}
