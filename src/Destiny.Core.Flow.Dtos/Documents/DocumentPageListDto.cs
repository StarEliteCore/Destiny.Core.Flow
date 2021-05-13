
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Destiny.Core.Flow.Entity;
using Destiny.Core.Flow.Mapping;
using Destiny.Core.Flow.Entities;
namespace Destiny.Core.Flow.Dtos
{

    /// <summary>
    /// 文档
    /// </summary>
    [AutoMapping(typeof(Document))]
    public partial class DocumentPageListDto : OutputDto<Guid>
    {
        /// <summary>
        /// 获取或设置 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 获取或设置 文档类型ID
        /// </summary>
        public Guid DocumentTypeId { get; set; }

        /// <summary>
        /// 获取或设置 文档类型名字
        /// </summary>
        public string DocumentTypeName { get; set; }

        /// <summary>
        /// 获取或设置 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 获取或设置创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

    }

}