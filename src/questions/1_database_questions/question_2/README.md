# Starting Your PostgreSQL Container
```
docker run --name dummy-postgres \
  -e POSTGRES_PASSWORD=mysecretpassword \
  -e POSTGRES_USER=myuser \
  -e POSTGRES_DB=my_dummy_db \
  -p 5432:5432 \
  -d postgres
```

# Connecting to the PostgreSQL Shell
```
docker exec -it dummy-postgres bash
```

# Connecting to the PostgreSQL Database
```
psql -U myuser -d my_dummy_db
```

# Copy the CSV File to the Docker Container
```
docker cp data/[file_name].csv dummy-postgres:/tmp/[file_name].csv
docker exec -it dummy-postgres bash
ls /tmp
```

# Other
```
- docker logs dummy-postgres
- docker stop dummy-postgres
- docker rm dummy-postgres
```