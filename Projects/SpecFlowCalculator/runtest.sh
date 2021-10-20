#!/bin/bash
dotnet test --logger:"console;verbosity=detailed" | tee ./TESTLOG.txt

cd SpecFlowCalculator.Spec/bin/Debug/net5.0/

livingdoc test-assembly "./SpecFlowCalculator.Spec.dll" -t "./TestExecution.json"

firefox *.html