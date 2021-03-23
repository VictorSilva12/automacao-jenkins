pipeline{
    agent any
    stages{
        stage ('Build Back-end'){
            steps {
                sh 'dotnet restore'
                echo 'Restore Ok'
                sh 'dotnet clean'
                echo 'Clean Ok'
                sh 'dotnet build --configuration Release'
                echo 'Build Ok'
            }
        }
        stage ('Pack')
        {
            steps{
                sh 'dotnet pack --no-build --output nupkgs'
                echo 'nupkgs criado'
            }
        }
        stage ('Testing'){
            steps{
                sh 'dotnet test'
            }
        }
    }
}