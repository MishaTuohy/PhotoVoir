using Dapper;
using Microsoft.Extensions.Configuration;
using Photovoir.Data;
using Photovoir.Interfaces;
using Photovoir.Services.Utils;
using Photovoir.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Services.Persistence.Helper
{
    public class SqlHelper : DatabaseUtils, ISqlHelper
    {
        public SqlHelper(IConfiguration config) : base(config) { }

        public async Task<int> ExecuteQueryAsync(IDbConnection _connection, IDbTransaction _transaction, string sql, List<ParameterInfo> parameters, CommandType _commandType)
        {
            DynamicParameters _params = new DynamicParameters();

            if (parameters != null)
            {
                foreach (var param in parameters)
                    _params.Add("@" + param.Name, param.Value);
            }

            return await _connection.ExecuteAsync(sql, _params, transaction: _transaction, commandType: _commandType);
        }

        public async Task<int> ExecuteScalarAsync(IDbConnection _connection, IDbTransaction _transaction, string sql, List<ParameterInfo> parameters, CommandType _commandType)
        {
            DynamicParameters _params = new DynamicParameters();

            if (parameters != null)
            {
                foreach (var param in parameters)
                    _params.Add("@" + param.Name, param.Value);
            }

            return await _connection.ExecuteScalarAsync<int>(sql, _params, transaction: _transaction, commandType: _commandType); ;
        }

        public async Task<T> GetRecordAsync<T>(string sql, List<ParameterInfo> parameters, CommandType _commandType)
        {
            using IDbConnection _connection = CreateConnection();
            DynamicParameters _params = new DynamicParameters();

            if (parameters != null)
            {
                foreach (var param in parameters)
                    _params.Add("@" + param.Name, param.Value);
            }

            return (await _connection.QueryAsync<T>(sql, param: _params, commandType: _commandType, commandTimeout: 180)).FirstOrDefault();
        }

        public async Task<List<T>> GetRecordsAsync<T>(string sql, List<ParameterInfo> parameters, CommandType _commandType)
        {
            using IDbConnection _connection = CreateConnection();
            DynamicParameters _params = new DynamicParameters();

            if (parameters != null)
            {
                foreach (var param in parameters)
                    _params.Add("@" + param.Name, param.Value);
            }

            return (await _connection.QueryAsync<T>(sql, param: _params, commandType: _commandType, commandTimeout: 180)).ToList();
        }
    }
}
