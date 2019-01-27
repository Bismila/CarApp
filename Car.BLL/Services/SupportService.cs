using Car.BLL.DTO;
using Car.BLL.Interfaces;
using Car.BLL.MapperProvider;
using Car.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.BLL.Services
{
    public class SupportService : ISupportService
    {
        private IAutoMapperProvider _mapper;
        private readonly ISupportRepository _supportRepository;
        public SupportService(IAutoMapperProvider mapper, ISupportRepository supportRepository)
        {
            _mapper = mapper;
            _supportRepository = supportRepository;
        }

        public Task Create(SupportsDto item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetAll()
        {
            var supportsList = await _supportRepository.GetAll();
            var list = new List<string>();
            foreach (var model in supportsList)
            {
                list.Add(model.Name);
            }
            return list;
        }

        public Task<bool> Update(SupportsDto item)
        {
            throw new NotImplementedException();
        }
    }
}
