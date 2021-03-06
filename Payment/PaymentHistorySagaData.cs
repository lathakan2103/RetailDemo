﻿using System;
using NServiceBus;

namespace Payment
{
	public class PaymentHistorySagaData : IContainSagaData
	{
		public Guid Id { get; set; }
		public string Originator { get; set; }
		public string OriginalMessageId { get; set; }
		public Guid CustomerId { get; set; }
	}
}