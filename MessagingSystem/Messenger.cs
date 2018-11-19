﻿using JetBrains.Annotations;

namespace MessagingSystem
{
    public interface Messenger
    {
        void SendMessage([NotNull] object message);
    }
}