#!/usr/bin/env bash

export PROTOC=$HOME/.nuget/packages/google.protobuf.tools/3.6.1/tools/linux_x64/protoc
export PLUGIN=$HOME/.nuget/packages/grpc.tools/1.15.0-pre1/tools/linux_x64/grpc_csharp_plugin

$PROTOC -I ./protos --csharp_out StringLength ./protos/StringLength.proto --grpc_out StringLength --plugin=protoc-gen-grpc=$PLUGIN