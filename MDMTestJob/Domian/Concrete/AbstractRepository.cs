using MDMTestJob.Domian.Entity;
using System;

namespace MDMTestJob.Domian.Concrete
{

    public  abstract class AbstractRepository
    {

        protected MdmTestJob_dbEntities context { get; set; }
        protected abstract void Save(Object other);
        
    }
}
