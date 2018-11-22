﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanium.erp.data
{
    public interface IUnitOfWork {

        void Commit();
        void Rollback();
        void BeginTransaction();
        void OpenConnection();
        void CloseConnection();
    }

}
