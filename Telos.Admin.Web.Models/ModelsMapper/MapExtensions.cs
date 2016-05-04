using System;
using AutoMapper;

namespace Telos.Admin.Web.Models.ModelsMapper
{
    public static class MapExtensions
    {
        public static T To<T>(this Object from)
        {
            return Mapper.Map<T>(from);
        }
    }
}
