pipeline {
    agent any

   environment {
       NUGET_RESTORE = 'C:/D/Tools/nuget.exe restore'
   }
   
   stages{
       
       stage('Checkout code'){
           steps {
            git 'https://github.com/TLHLusincho/ExampleWithNGRepos.git'
       }
       }
       
       stage('Restore Nuget'){
           steps{
                 bat "$NUGET_RESTORE ExampleWithNG/ExampleWithNG.sln"
           }
       }
       
       stage('Build'){
           steps{
               bat "\"${tool 'msbuild'}\" ExampleWithNG/ExampleWithNG.sln"
           }
       }
       
   }
    
}
