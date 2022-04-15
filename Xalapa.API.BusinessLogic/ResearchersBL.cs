using System;
using Xalapa.API.DataAccess;
using Xalapa.API.Entities;

namespace Xalapa.API.BusinessLogic
{
    public class ResearchersBL
    {
        private ResearcherDAO dao = new ResearcherDAO();

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

        public void Insert(Researchers entity)
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

        public void Update(Researchers entity)
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

        public Researchers Get(int entityId)
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

        public Researchers GetList()
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