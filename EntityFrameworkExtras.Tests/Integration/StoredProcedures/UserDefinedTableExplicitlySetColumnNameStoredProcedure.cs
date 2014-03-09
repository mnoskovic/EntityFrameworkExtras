﻿using System.Collections.Generic;
using System.Data;

namespace EntityFrameworkExtras.Tests.Integration.StoredProcedures
{
    [StoredProcedure("UserDefinedTableStoredProcedure")]
    public class UserDefinedTableExplicitlySetColumnNameStoredProcedure
    {
        [StoredProcedureParameter(SqlDbType.Udt)]
        public List<ExplicitySetColumnNamesUserDefinedTable> UserDefinedTableParameter { get; set; }
    }
}