﻿using App.Common.Constants;
using System;

namespace App.Common.Models
{
    public sealed class AppResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public int? StatusCode { get; set; }

        public static AppResponse Response(bool isSuccess, string message, HttpStatusCodes statusCode = HttpStatusCodes.OK)
        {
            return new AppResponse
            {
                IsSuccess = isSuccess,
                Message = message,
                StatusCode = Convert.ToInt32(statusCode)
            };
        }

        public static AppResponse<TModel> Fail<TModel>(TModel data, string message = "", HttpStatusCodes statusCode = HttpStatusCodes.InternalServerError)
        {
            return new AppResponse<TModel>
            {
                IsSuccess = false,
                Message = message,
                StatusCode = Convert.ToInt32(statusCode),
                Data = data,
            };
        }

        public static AppResponse<TModel> Success<TModel>(TModel data, string message = "", HttpStatusCodes statusCode = HttpStatusCodes.OK)
        {
            return new AppResponse<TModel>
            {
                IsSuccess = true,
                Message = message,
                StatusCode = Convert.ToInt32(statusCode),
                Data = data,
            };
        }

        internal static AppResponse Response(bool v1, string v2, object badRequest)
        {
            throw new NotImplementedException();
        }
    }

    public sealed class AppResponse<TModel>
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public int? StatusCode { get; set; }
        public TModel Data { get; set; }
    }
}
