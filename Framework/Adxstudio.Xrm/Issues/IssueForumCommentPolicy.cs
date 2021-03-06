/*
  Copyright (c) Microsoft Corporation. All rights reserved.
  Licensed under the MIT License. See License.txt in the project root for license information.
*/

namespace Adxstudio.Xrm.Issues
{
	/// <summary>
	/// Specifies how comment postings work for issues in an issue forum and how they are displayed.
	/// </summary>
	public enum IssueForumCommentPolicy
	{
		/// <summary>
		/// Submissions from all users, anonymous and authenticated, are allowed and displayed immediately.
		/// </summary>
		Open                     = 100000000,
		
		/// <summary>
		/// Only submissions from authenticated users are allowed and they are displayed immediately.
		/// </summary>
		OpenToAuthenticatedUsers = 100000001,
		
		/// <summary>
		/// Submissions from all users, anonymous or authenticated, are allowed. The submissions will not be displayed until a moderator approves them.
		/// </summary>
		Moderated                = 100000002,
		
		/// <summary>
		/// Existing submissions are displayed, but no new submissions are allowed.
		/// </summary>
		Closed                   = 100000003,
		
		/// <summary>
		/// User submissions are disabled. No submissions can be made or viewed.
		/// </summary>
		None                     = 100000004
	}
}
