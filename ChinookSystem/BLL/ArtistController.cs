using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Additonal Namespaces
using System.ComponentModel;
using ChinookSystem.VIEWMODELS;
using ChinookSystem.DAL;
using ChinookSystem.ENTITIES;

namespace ChinookSystem.BLL
{
    [DataObject]
    public class ArtistController
    {

        #region Queries
        //Due to the fact that the entities will be internal
        //you will NOT be able to use them directly as return datatypes.
        //Instead, we will create viewmodel classes that will contain the data definition
        //for your return data type.
        //To fill these view classes we will use a simple Linq query.
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ArtistViewModel> Artist_List()
        {
            using (var context = new ChinookSystemContext())
            {
                //linq query
                //linq queries are returned as IEnumerable or IQueryable datasets
                //you can use var when declaring your query receiving variable
                var results = from x in context.Artists
                              select new ArtistViewModel
                              {
                                  ArtistId = x.ArtistId,
                                  ArtistName = x.Name
                              };
                return results.OrderBy(x => x.ArtistName).ToList();
            }
        }
        #endregion
        #region CRUD
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public void Artists_Insert(ArtistViewModel item) 
        { 
            using (var context = new ChinookSystemContext())
            {
                Artist info = new Artist()
                {
                    Name = item.ArtistName
                };
                context.Artists.Add(info);
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Artists_Update(ArtistViewModel item)
        {
            using (var context = new ChinookSystemContext())
            {
                Artist info = new Artist()
                {
                    ArtistId = item.ArtistId,
                    Name = item.ArtistName
                };
                
                context.Entry(info).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Artists_Delete(ArtistViewModel item)
        {
            using (var context = new ChinookSystemContext())
            {
                Artists_Delete(item.ArtistId);
            }
        }
        public void Artists_Delete(int artistid)
        {
            using (var context = new ChinookSystemContext())
            {
                var existing = context.Artists.Find(artistid);
                context.Artists.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
       
    }
}
