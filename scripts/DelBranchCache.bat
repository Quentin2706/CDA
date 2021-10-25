echo off
NET STOP BranchCache
NET START wampapache64
NET START wampmysqld64
start c:\wamp64\wampmanager.exe