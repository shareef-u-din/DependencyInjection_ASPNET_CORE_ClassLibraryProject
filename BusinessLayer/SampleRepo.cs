using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class SampleRepo : ISampleRepo
    {
        private ISample _sample;
        public SampleRepo(ISample sample)
        {
            _sample = sample;
        }


        public string GetData()
        {
            return _sample.GetAll();
        }
    }
}
