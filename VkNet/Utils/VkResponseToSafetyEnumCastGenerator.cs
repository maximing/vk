﻿// Autogenerated at 07.12.2015 17:39:11
// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY
using VkNet.Enums.SafetyEnums;
namespace VkNet.Utils
{
    partial class VkResponse
    {
		public static implicit operator Deactivated(VkResponse response)
		{
            return response == null ? null :  Deactivated.FromJson(response);
        }
		public static implicit operator GroupType(VkResponse response)
		{
            return response == null ? null :  GroupType.FromJson(response);
        }
		public static implicit operator LikesFilter(VkResponse response)
		{
            return response == null ? null :  LikesFilter.FromJson(response);
        }
		public static implicit operator LinkAccessType(VkResponse response)
		{
            return response == null ? null :  LinkAccessType.FromJson(response);
        }
		public static implicit operator NewsObjectTypes(VkResponse response)
		{
            return response == null ? null :  NewsObjectTypes.FromJson(response);
        }
		public static implicit operator NewsTypes(VkResponse response)
		{
            return response == null ? null :  NewsTypes.FromJson(response);
        }
		public static implicit operator OccupationType(VkResponse response)
		{
            return response == null ? null :  OccupationType.FromJson(response);
        }
		public static implicit operator PhotoSizeType(VkResponse response)
		{
            return response == null ? null :  PhotoSizeType.FromJson(response);
        }
		public static implicit operator Platform(VkResponse response)
		{
            return response == null ? null :  Platform.FromJson(response);
        }
		public static implicit operator PostSourceType(VkResponse response)
		{
            return response == null ? null :  PostSourceType.FromJson(response);
        }
		public static implicit operator PostType(VkResponse response)
		{
            return response == null ? null :  PostType.FromJson(response);
        }
		public static implicit operator Privacy(VkResponse response)
		{
            return response == null ? null :  Privacy.FromJson(response);
        }
		public static implicit operator RelativeType(VkResponse response)
		{
            return response == null ? null :  RelativeType.FromJson(response);
        }

	}
}