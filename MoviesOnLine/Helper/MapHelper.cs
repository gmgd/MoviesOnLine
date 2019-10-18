using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using entity = MoviesOnLine.Data.Entities;
using model = MoviesOnLine.Models;

namespace MoviesOnLine.Helper
{
    public class MapHelper
    {
        internal static IMapper mapper;

        public static T Map<T>(object source)
        {
            return mapper.Map<T>(source);
        }

        static MapHelper()
        {
            var config = new MapperConfiguration(x =>
            { x.CreateMap<entity.Movie, model.MovieList>().ReverseMap(); });

            mapper = config.CreateMapper();
        }
    }
}