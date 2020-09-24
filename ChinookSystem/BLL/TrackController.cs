using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;
using ChinookSystem.VIEWMODELS;
using ChinookSystem.DAL;
using ChinookSystem.ENTITIES;

namespace ChinookSystem.BLL
{
    [DataObject]
    public class TrackController
    {
        #region
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<TrackViewModel> Track_List() 
        {
            using (var context = new ChinookSystemContext())
            {
                //linq query
                //linq queries are returned as IEnumerable or IQueryable datasets
                //you can use var when declaring your query receiving variable
                var results = from x in context.Tracks
                              select new TrackViewModel
                              {
                                  TrackId = x.TrackId,
                                  Name = x.Name,
                                  AlbumId = x.AlbumId,
                                  MediaTypeId = x.MediaTypeId,
                                  GenreId = x.GenreId,
                                  Composer = x.Composer,
                                  Milliseconds = x.Milliseconds,
                                  Bytes = x.Bytes,
                                  UnitPrice = x.UnitPrice
                                  
                              };
                return results.OrderBy(x => x.Name).ToList();
            }
        }
        #endregion

        #region CRUD
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public void Tracks_Insert(TrackViewModel item)
        {
            using (var context = new ChinookSystemContext())
            {
                Track info = new Track()
                {
                    Name = item.Name,
                    AlbumId = item.AlbumId,
                    MediaTypeId = item.MediaTypeId,
                    GenreId = item.GenreId,
                    Composer = item.Composer,
                    Milliseconds = item.Milliseconds,
                    Bytes = item.Bytes,
                    UnitPrice = item.UnitPrice                  
                };
                context.Tracks.Add(info);
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Tracks(TrackViewModel item)
        {
            using (var context = new ChinookSystemContext())
            {
                Track info = new Track()
                {
                    TrackId = item.TrackId,
                    Name = item.Name,
                    AlbumId = item.AlbumId,
                    MediaTypeId = item.MediaTypeId,
                    GenreId = item.GenreId,
                    Composer = item.Composer,
                    Milliseconds = item.Milliseconds,
                    Bytes = item.Bytes,
                    UnitPrice = item.UnitPrice
                };
                //problem here, check source code when robbin uploads it
                context.Entry(info).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Tracks_Delete(TrackViewModel item)
        {
            using (var context = new ChinookSystemContext())
            {
                Tracks_Delete(item.TrackId);
            }
        }
        public void Tracks_Delete(int trackid)
        {
            using (var context = new ChinookSystemContext())
            {
                var existing = context.Tracks.Find(trackid);
                context.Tracks.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
