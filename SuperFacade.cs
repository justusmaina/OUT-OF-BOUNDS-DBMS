using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
   public class PTSSuperFacade : MarshalByRefObject
    {
        protected DAO.SuperDAO dao;
        public PTSSuperFacade(DAO.SuperDAO dao)
        {
            this.dao = dao;
        }
        public Task[] GetListOfTasks(Guid projectId)
        {
            return (dao.GetListOfTasks(projectId)).ToArray();
        }
    }
}
