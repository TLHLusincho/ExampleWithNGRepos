node {
    stage 'Checkout code'
       git 'https://github.com/TLHLusincho/ExampleWithNGRepos.git'
    stage 'Restore Nuget'
       bat 'C:/D/Tools/nuget.exe restore ExampleWithNG/ExampleWithNG.sln'
    stage 'Build'
       bat "\"${tool 'msbuild'}\" ExampleWithNG/ExampleWithNG.sln /p:Configuration=Debug /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
    stage 'Post build actions'
       archiveArtifacts 'ExampleWithNG\\ExampleWithNG\\bin\\Debug\\*exe'
}