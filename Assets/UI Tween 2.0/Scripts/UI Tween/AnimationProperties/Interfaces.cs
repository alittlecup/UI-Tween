﻿using UnityEngine;

public interface IFrameTicker
{
    void Tick(float deltaTime);
    bool IsUnscaledTicker();
}

public interface CorePropertyReader
{
    void Initialize(CoreProperty coreProperty);
}

public interface TweenExecutor
{
    void ExecuteTween(RectTransform animatedRect);
    void EnableExecutor();
    void DisableExecutor();
    bool isExecutorEnabled();
}
