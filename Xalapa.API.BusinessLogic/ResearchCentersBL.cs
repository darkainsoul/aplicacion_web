using System;
using Xalapa.API.DataAccess;
using Xalapa.API.Entities;

namespace Xalapa.API.BusinessLogic
{
    public class ResearchCentersBL
    {
        private ResearchCenterDAO dao = new ResearchCenterDAO();

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

        public void Insert(ResearchCenters entity)
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

        public void Update(ResearchCenters entity)
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

        public ResearchCenters Get(int entityId)
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

        public ResearchCenters GetList()
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