using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Photovoir.Data;
using Photovoir.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Services.Persistence.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISqlHelper _sqlHelper;
        private readonly ILogger<ProductRepository> _logger;
        private readonly IProductDao dao;
        private readonly IConfiguration _config;

        public ProductRepository(IConfiguration configuration, IProductDao dao, ILogger<ProductRepository> logger, ISqlHelper sqlHelper)
        {
            _config = configuration;
            _sqlHelper = sqlHelper;
            _logger = logger;
            this.dao = dao;
        }
        public async Task<bool> AddAsync(Product entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            bool result = false;
            using (Transaction trans = new Transaction(_config))
            {
                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo {Name = "Id", Value = entity.Id},
                        new ParameterInfo {Name = "AuthorId", Value = entity.AuthorId},
                        new ParameterInfo {Name = "Name", Value = entity.Name},
                        new ParameterInfo {Name = "Price", Value = entity.Price},
                        new ParameterInfo {Name = "Tags", Value = entity.Tags},
                        new ParameterInfo {Name = "Description", Value = entity.Description},
                    };
                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.InsertSql(), _params, CommandType.Text) > 0;

                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to create Product record in Database");
                    throw;
                }
            }
            return result;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            bool result = false;

            using (Transaction trans = new Transaction(_config))
            {
                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo { Name = "Id", Value = Id }
                    };
                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.DeleteSql(), _params, CommandType.Text) > 0;
                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to delete User");
                    throw;
                }
            }
            return result;
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            try
            {
                List<ParameterInfo> _params = new List<ParameterInfo>
                {
                    new ParameterInfo{ Name = "Id", Value = null }
                };
                return await _sqlHelper.GetRecordsAsync<Product>(dao.GetAllSql(), _params, CommandType.Text);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retreive Products");
                throw;
            }
        }

        public async Task<Product> GetByIdAsync(int Id)
        {
            try
            {
                List<ParameterInfo> _params = new List<ParameterInfo>
                {
                    new ParameterInfo { Name = "Id", Value = Id }
                };
                return await _sqlHelper.GetRecordAsync<Product>(dao.GetByIdSql(), _params, CommandType.Text);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve Product");
                throw;
            }
        }

        public async Task<bool> UpdateAllAsync(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Product data cannot be null");

            bool result;
            using (Transaction trans = new Transaction(_config))
            {
                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo {Name = "Id", Value = entity.Id},
                        new ParameterInfo {Name = "AuthorId", Value = entity.AuthorId},
                        new ParameterInfo {Name = "Name", Value = entity.Name},
                        new ParameterInfo {Name = "Price", Value = entity.Price},
                        new ParameterInfo {Name = "Tags", Value = entity.Tags},
                        new ParameterInfo {Name = "Description", Value = entity.Description},
                    };
                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.UpdateSql(), _params, CommandType.Text) > 0;

                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to update CDR Data");
                    throw;
                }
            }
            return result;
        }

        public async Task<bool> UpdateName(int Id, string Name)
        {
            bool result;
            using (Transaction trans = new Transaction(_config))
            {

                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo { Name = "Id", Value = Id },
                        new ParameterInfo { Name = "Name", Value = Name }
                    };

                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.UpdateNameSql(), _params, CommandType.Text) > 0;

                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to update PasswordHash");
                    throw;
                }
            }
            return result;
        }

        public async Task<bool> UpdatePrice(int Id, string Price)
        {
            bool result;
            using (Transaction trans = new Transaction(_config))
            {

                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo { Name = "Id", Value = Id },
                        new ParameterInfo { Name = "Price", Value = Price }
                    };

                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.UpdatePriceSql(), _params, CommandType.Text) > 0;

                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to update PasswordHash");
                    throw;
                }
            }
            return result;
        }

        public async Task<bool> UpdateTags(int Id, string Tags)
        {
            bool result;
            using (Transaction trans = new Transaction(_config))
            {

                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo { Name = "Id", Value = Id },
                        new ParameterInfo { Name = "Tags", Value = Tags }
                    };

                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.UpdateTagsSql(), _params, CommandType.Text) > 0;

                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to update PasswordHash");
                    throw;
                }
            }
            return result;
        }

        public async Task<bool> UpdateDescription(int Id, string Description)
        {
            bool result;
            using (Transaction trans = new Transaction(_config))
            {

                try
                {
                    List<ParameterInfo> _params = new List<ParameterInfo>
                    {
                        new ParameterInfo { Name = "Id", Value = Id },
                        new ParameterInfo { Name = "Description", Value = Description }
                    };

                    result = await _sqlHelper.ExecuteQueryAsync(trans.GetConnection(), trans.GetTransaction(), dao.UpdateDescriptionSql(), _params, CommandType.Text) > 0;

                    if (result)
                        trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    _logger.LogError(ex, "Failed to update PasswordHash");
                    throw;
                }
            }
            return result;
        }
    }
}
