using System;
using System.Collections.Generic;
using Xalapa.API.DataAccess;
using Xalapa.API.Entities;

namespace Xalapa.API.BusinessLogic
{
    public class ResearchProjectsBL
    {
        private ResearchProjectDAO dao = new ResearchProjectDAO();

        public void Delete(int entityId)
        {
            try
            {
                dao.Delete(entityId);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public void Insert(ResearchProjects entity)
        {
            try
            {
                dao.Insert(entity);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public void Update(ResearchProjects entity)
        {
            try
            {
                dao.Update(entity);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public ResearchProjects Get(int entityId)
        {
            try
            {
                return dao.Get(entityId);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

        public IEnumerable<ResearchProjects> GetList()
        {
            try
            {
                return dao.GetList();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }
    }
}