﻿using Shuttle.Core.Infrastructure;

namespace Shuttle.ESB.Msmq
{
	public class OnStart : PipelineEvent
	{
	}
	public class OnBeginTransaction : PipelineEvent
	{
	}
	public class OnReceiveMessage : PipelineEvent
	{
	}
	public class OnSendJournalMessage : PipelineEvent
	{
	}
	public class OnCommitTransaction : PipelineEvent
	{
	}
	public class OnDispose : PipelineEvent
	{
	}
}