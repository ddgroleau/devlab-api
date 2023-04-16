#!/usr/bin/bash

# Prerequisites:
#   * API is running on localhost:5000 with swagger accessible
#   * Widdershins is installed (npm install -g widdershins)

echo -e "\n🚀 \033[0;32mUpdating README with latest OpenAPI spec...\033[0m \n"

# Create OpenApi spec files
curl http://localhost:5000/swagger/v1/swagger.json > openapi.json
widdershins openapi.json -o openapi.md --omitHeader

# Remove all lines starting at Open Api Docs Header
sed -i '/# Open API Documentation/,$d' README.md

# Re-add the header
echo "# Open API Documentation" >> README.md

# Add an update timestamp
now=$(date -u)
echo "\`\`🔥 Last Updated: $now\`\`" >> README.md

# Add the Open Api spec as markdown
cat openapi.md >> README.md

# Remove redundant headers & comments
sed -i '/<h1 id="webapi"*/d' README.md
sed -i '/<!-- Generator: Widdershins*/d' README.md

echo -e "\n✅ \033[0;32m README Updated with latest OpenAPI spec\033[0m"
