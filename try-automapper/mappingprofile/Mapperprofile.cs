using AutoMapper;
using try_automapper.DTOS;
using try_automapper.Models;

namespace try_automapper.mappingprofile
{
    public class Mapperprofile:Profile
    {
        public Mapperprofile()
        {
            // maping [Source] to [destination]
            CreateMap<EmployeeDTO, Employee>();
        }
    }
}
