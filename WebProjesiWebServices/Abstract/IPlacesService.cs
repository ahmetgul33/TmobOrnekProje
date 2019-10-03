using System;
using System.Collections.Generic;
using System.Text;
using WebProjesiDataAccess.Models;

namespace WebProjesiWebServices.Abstract
{
  public  interface IPlacesService
    {
        Place GetPlaces(int id);
        IEnumerable<Place> GetAllPlaces();
        void Add(Place dPlaces);
        void Update(Place dPlaces);
        void Delete(Place dPlaces);
    }
}
