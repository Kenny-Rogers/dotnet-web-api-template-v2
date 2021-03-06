using System;
using WebProject.Template.Domain.Models;

namespace WebProject.Template.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse
    {
        public readonly Category Category;

        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }        

        /// <summary>
        /// Creates a success response
        /// </summary>
        /// <param name="category">Saved category</param>
        /// <returns>Response</returns>
        public CategoryResponse(Category category) : this(true, string.Empty, category){}

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>Response</returns>
        public CategoryResponse(string message) : this(false, message, null){}
    }
}