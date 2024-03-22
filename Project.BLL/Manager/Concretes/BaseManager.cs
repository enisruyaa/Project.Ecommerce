using Project.BLL.Manager.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager.Concretes
{
    // Abstract olmamasının ciddi bir nedeni var : Çünkü BaseManager'dan instance alınmasının mümkün olmasını istiyoruz.

    // Önemli : Normal şartlarda bir Manager yapısı sadece Domain Entity almaz.. Buradaki metotlar DTO da almalıdır (Data Transfer Object) . Biz bir Domain Entity üzerinden iş akışı işlemlerini sağlıklı bir şekilde yapamayız.

    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        // Bu class Repository ile birlikte çalışmak ister
        protected readonly IRepository<T> _iRep;

        public BaseManager(IRepository<T> iRep) // Burada dikkat ederseniz BaseManager constractor'i bir Parametre alıyor (IRepository <T> tipinde) IOC (Inversion Of Controls) paternine göre burada belirtilen tip Middleware'de görülürse bize instance'i alınabilecek bir şey gönderilir. Bizim istediğimiz IRepository<T> generic tipi algılandığı anda BaseRepository intance'i gönderilecektir. Bu yüzdendir ki BaseRepository'i Abstract Yapmadık.
        {
            _iRep = iRep;
        }

        void SaatEkle(T item)
        {
            item.CreatedDate = item.CreatedDate.AddHours(3); // Bu metot ile yaratılma tarihine 3 saat eklemiş oluyoruz.
        }

        public virtual string Add(T item)
        {
            // Saat Ekle(DTO)
            SaatEkle(item);

            // Maping => DTO => DomainEntity
            _iRep.Add(item);
            return "Ekleme Başarılıdır";
        }

        public async Task AddAsync(T item)
        {
            SaatEkle(item);
            await _iRep.AddAsync(item);
        }

        bool ElemanKontrol(List<T> list)
        {
            if (list.Count > 10) return false;
            return true;
        }

        public string AddRange(List<T> list)
        {
            if (!ElemanKontrol(list)) return "Maksimum 10 veri ekleyebileceğiniz için işlem gerçekleştirilemedi";
            _iRep.AddRange(list);
            return "Ekleme başarılı bir şekilde gerçekleştirildi";
        }

        public async Task<string> AddRangeAsync(List<T> list)
        {
            if (!ElemanKontrol(list)) return "Maksimum 10 veri ekleyebileceğiniz için işlem gerçekleştirilemedi";
            await _iRep.AddRangeAsync(list);
            return "Ekleme Başarılıdır";
        }

        //DTO => Domain Entity 

        // UI -> Any Expression<Func<DTO,bool>>
        // BLL -> Any Expression<Func<Domain,bool>>

        public bool Any(Expression<Func<T, bool>> exp)
        {
            // Exp kontrol işlemleri
            return _iRep.Any(exp);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRep.AnyAsync(exp);
        }

        public void Delete(T item)
        {
            if(item.CreatedDate == default)
            {
                return;
            }
            _iRep.Delete(item);
        }

        public void DeleteRange(List<T> list)
        {
            _iRep.DeleteRange(list);
        }

        public string Destroy(T item)
        {
            if (item.Status == ENTITIES.Enums.DataStatus.Deleted)
            {
                _iRep.Destroy(item);
                return "Veri Başarıyla Yok Edildi.";
            }
            return $"Veriyi silemezsiniz çünkü {item.ID} {item.Status} Pasif Değil";
        }

        public string DestroyRange(List<T> list)
        {
            // Todo : Challange ödeve bakınız çünkü mevcut durumda istediğimiz şekilde çalışmayacaktır.
            foreach(T item in list) return Destroy(item);
            return "Silme işleminde bir sorunla karşılaşıldı lütfen veri durumunun pasif olduğundan emin olunuz";
        }

        public async Task<T> FindAsync(int id)
        {
            return await _iRep.FindAsync(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _iRep.FirstOrDefault(exp);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRep.FirstOrDefaultAsync(exp);
        }

        public List<T> GetActives()
        {
            return _iRep.GetActives();
        }

        public Task<List<T>> GetActivesAsync()
        {
            return _iRep.GetActivesAsync();
        }

        public List<T> GetAll()
        {
            return _iRep.GetAll();
        }

        public List<T> GetFirstDatas(int count)
        {
            return _iRep.GetFirstDatas(count);
        }

        public List<T> GetLastDatas(int count)
        {
            return _iRep.GetLastDatas(count);
        }

        public List<T> GetModifieds()
        {
            return _iRep.GetModifieds();
        }

        public List<T> GetPassives()
        {
            return _iRep.GetPassives();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _iRep.Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _iRep.Select(exp);
        }

        public async Task UpdateAsync(T item)
        {
            await _iRep.UpdateAsync(item);
        }

        public async Task UpdateRangeAsync(List<T> list)
        {
            await _iRep.UpdateRangeAsync(list);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _iRep.Where(exp);
        }

        public List<string> DestroyRangeWithText(List<T> list)
        {
            List<string> metinler = new List<string>();
            if (list == null || list.Count == 0)
            {
                metinler.Add("Listeye Girilemedi");
                return metinler;
            }
            foreach (T item in list) metinler.Add(Destroy(item));
            return metinler;
        }
    }
}
