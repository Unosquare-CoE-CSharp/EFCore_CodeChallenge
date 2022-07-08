param([string]$tag="1.0.0")
docker build --file LocalSQL.dockerfile  --tag localsql:$tag .