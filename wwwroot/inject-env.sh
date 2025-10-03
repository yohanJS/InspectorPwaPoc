#!/bin/bash
sed -i "s|env:PUBLIC_API_KEY|${PUBLIC_API_KEY}|" wwwroot/appsettings.json