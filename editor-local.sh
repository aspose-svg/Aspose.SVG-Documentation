# Script for launch editor for local file system
# netlify-cms-proxy-server used port 8082
# For setting this port see  .env file PORT=8082
# and same port need set in  static/editor-local/config.xml
# as local_backend.url: http://localhost:8082/api/v1
npx netlify-cms-proxy-server &
hugo server