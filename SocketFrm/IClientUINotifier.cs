﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketFrm
{
    public interface IClientUINotifier
    {
        AutoResetEvent ClientWantsShutdown { get; }

        void HandleDisplayTextServerMessage(DisplayTextServerMessage displayTextServerMessage);
        void HandleRegisterIDResultServerMessage(RegisterIdResultServerMessage registerIdResultServerMessage, IPeerMessageTransmitter clientAppState);
        void HandleClientAvailabilityNotificationServerMessage(ClientAvailabilityNotificationServerMessage clientAvailabilityNotificationServerMessage);
        void HandleTransmitToPeerResultServerMessage(TransmitToPeerResultServerMessage transmitToPeerResultServerMessage);
        void HandleTransmitToPeeServerMessage(TransmitToPeerServerMessage transmitToPeerServerMessage);
        void RequestRegistrationIdFromUser();
    }
}