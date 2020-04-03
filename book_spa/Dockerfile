FROM node:12.2.0-alpine AS build

COPY package.json /app/package.json

WORKDIR /app
RUN npm install

COPY ./src /app/src
COPY ./public /app/public

FROM node:12.2.0-alpine
WORKDIR /app
COPY --from=build /app .
CMD ["npm", "start"]