﻿//------------------------------------------------------------------------------
// <copyright file="ExistsPredicate.cs"
//  company="Scott Dorman"
//  library="Cadru">
//    Copyright (C) 2001-2015 Scott Dorman.
// </copyright>
//
// <license>
//    Licensed under the Microsoft Public License (Ms-PL) (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </license>
//------------------------------------------------------------------------------

namespace Cadru.Data.Dapper.Predicates.Internal
{
    using global::Dapper;
    using System;

    internal class ExistsPredicate<TModel> : IExistsPredicate
        where TModel : class
    {
        public bool Not { get; set; }

        public IPredicate Predicate { get; set; }

        public string GetSql(DynamicParameters parameters)
        {
            string sql = null;
            ITableMap classMap;
            if (Database.Mappings.TryGetValue(typeof(TModel), out classMap))
            {
                sql = $"({(Not ? "NOT " : String.Empty)}EXISTS (SELECT 1 FROM {classMap.TableName} WHERE {Predicate.GetSql(parameters)}))";
            }

            return sql;
        }
    }
}
