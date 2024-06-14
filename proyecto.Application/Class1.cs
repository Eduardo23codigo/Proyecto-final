using proyecto.Domain;
using proyecto.Infrastructure;

namespace proyecto.Application
{
    public class SampleService
    {
        private readonly ISampleRepository _repository;

        public SampleService(ISampleRepository repository)
        {
            _repository = repository;
        }

        public void CreateSample(string name)
        {
            var entity = new SampleEntity { Name = name };
            _repository.Add(entity);
        }
    }
}