using System;
using System.Collections.Generic;
using Xalapa.API.DataAccess;
using Xalapa.API.Entities;

namespace Xalapa.API.BusinessLogic
{
    public class ThesisStudentsBL
    {
        private ThesisStudentDAO dao = new ThesisStudentDAO();

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

        public void Insert(ThesisStudents entity)
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

        public void Update(ThesisStudents entity)
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

        public ThesisStudents Get(int entityId)
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

        public IEnumerable<ThesisStudents> GetList()
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