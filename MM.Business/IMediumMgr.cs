using MM.Model;
using System;
using System.Collections.Generic;

namespace MM.Business
{
    public interface IMediumMgr
    {
        /// <summary>
        /// 获取系统中所有的介质
        /// </summary>
        IEnumerable<Medium> GetAll();

        /// <summary>
        /// 根据介质Id，获取介质对象
        /// </summary>
        /// <returns></returns>
        Medium GetById(Guid mediumId);

        /// <summary>
        /// 保存Medium对象
        /// </summary>
        void Save(Medium medium);

        /// <summary>
        /// 根据介质Id，删除介质对象
        /// </summary>
        void Delete(Guid mediumId);
    }
}
