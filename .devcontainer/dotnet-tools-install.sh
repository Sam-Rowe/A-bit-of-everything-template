cd web-api
dotnet restore
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
cat << \EOF >> ~/.zshrc
export PATH=$PATH:/root/.dotnet/tools"
EOF
