using System;
using System.Collections.Generic;
using Xalapa.API.DataAccess;
using Xalapa.API.Entities;

namespace Xalapa.API.BusinessLogic
{
    public class AcademicGroupsBL
    {
        private AcademicGroupDAO dao = new AcademicGroupDAO();

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

        public void Insert(AcademicGroups entity)
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

        public void Update(AcademicGroups entity)
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

        public AcademicGroups Get(int entityId)
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

        public IEnumerable<AcademicGroups> GetList()
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