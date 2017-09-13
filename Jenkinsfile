node {
   stage('Clear Working Directory') { // for display purposes
        sh 'sudo rm -r -f src/*'
		deleteDir()
   }
   stage('Copy Source Code') { // for display purposes
		sh 'cp -r ../API_SEOM@script/aspnet-core/src/ .'
   } 
   stage('Build dotnet') {
        dir('src/AbpCompanyName.AbpProjectName.EntityFrameworkCore') {
            sh 'sudo dotnet restore'
        }
        dir('src/AbpCompanyName.AbpProjectName.Web.Host') {
            sh 'sudo dotnet build'
        }
   }
   stage('Do deploy') {
        sh 'sudo rm -r -f /opt/p7/aspnet-core/src/AbpCompanyName.AbpProjectName.Web.Host/bin/Debug/netcoreapp2.0/*'
        sh 'sudo supervisorctl stop PhotoGalleryP7'
        sh 'sudo cp -r src/AbpCompanyName.AbpProjectName.Web.Host/bin/Debug/netcoreapp2.0/* /opt/p7/aspnet-core/src/AbpCompanyName.AbpProjectName.Web.Host/bin/Debug/netcoreapp2.0'
        sh 'sudo supervisorctl start PhotoGalleryP7'    
   }
}