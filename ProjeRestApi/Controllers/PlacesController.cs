using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProjesiDataAccess.Models;
using WebProjesiWebServices.Abstract;

namespace ProjeRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlacesService _placeService;


        public PlacesController(IPlacesService placeService)
        {
            _placeService = placeService;
        }
        [HttpGet]
        public List<Place> Get()
        {
            var list = _placeService.GetAllPlaces().ToList();
            return list;
        }

        [HttpGet("{id}")]
        public Place Get(int id)
        {
            return _placeService.GetPlaces(id);
        }
        [HttpPost]
        public void Post([FromForm] Place places)
        {
            _placeService.Add(places);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}