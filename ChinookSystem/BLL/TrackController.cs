using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;
using ChinookSystem.VIEWMODELS;
using ChinookSystem.DAL;

namespace ChinookSystem.BLL
{
    [DataObject]
    public class TrackController
    {
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
    }
}
