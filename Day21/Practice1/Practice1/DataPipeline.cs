using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class DataPipeline<T>
    {
        private readonly List<Func<IEnumerable<T>, IEnumerable<T>>> _pipeline = new();

        public DataPipeline<T> AddStep(Func<IEnumerable<T>, IEnumerable<T>> step)
        {
            _pipeline.Add(step);
            return this;
        }

        public IEnumerable<T> Process(IEnumerable<T> input)
        {
            return _pipeline.Aggregate(input, (current, step) => step(current));
        }
    }
}
