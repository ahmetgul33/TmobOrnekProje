using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WebProjesiDataAccess.Models;
using WebProjesiPosData.Abstract;
using WebProjesiWebServices.Abstract;

namespace WebProjesiWebServices.Concrete
{
    [Route("[controller]")]
    [ApiController]
    public class PlacesService : IPlacesService
    {
        private readonly IPlaceRepository _placeRepository;

        public PlacesService(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }
        public void Add(Place dPlaces)
        {
            _placeRepository.Add(dPlaces);
        }

        public void Delete(Place dPlaces)
        {
            _placeRepository.Delete(dPlaces);
        }

        public IEnumerable<Place> GetAllPlaces()
        {
            return _placeRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Place GetPlaces(int id)
        {
            return _placeRepository.Get(x => x.Id == id);
        }

        //public Places GetPlaces(int id)
        //{
        //    return _PlaceRepository.Get(x => x.Id == id);
        //}

        public void Update(Place dPlaces)
        {
            _placeRepository.Update(dPlaces);
        }

       
    }
}
