IMAGE_NAME=memory-tests
CONTAINER_NAME=memory-tests-container
echo "Removing existing container(s) of image $IMAGE_NAME..."
docker rm -f $(docker ps -aq -f "ancestor=$IMAGE_NAME") > /dev/null 2>&1
echo "Building image $IMAGE_NAME..."
docker build -t $IMAGE_NAME .
echo "Creating and starting container $CONTAINER_NAME..."
docker run --memory 4g --name $CONTAINER_NAME $IMAGE_NAME
