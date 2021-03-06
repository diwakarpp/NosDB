// /*
// * Copyright (c) 2016, Alachisoft. All Rights Reserved.
// *
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// *
// * http://www.apache.org/licenses/LICENSE-2.0
// *
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// */
using System.Data;
using System.Data.Common;

namespace Alachisoft.NosDB.ADO.NETProvider
{
    public class NosRowUpdatingEventArgs : RowUpdatingEventArgs
    {
        public NosRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
            : base(row, command, statementType, tableMapping)
        {
        }

        // Hide the inherited implementation of the command property.
        new public DbCommand Command
        {
            get { return (NosDbCommand)base.Command; }
            set { base.Command = value; }
        }
    }
}