### Stage: 1 ###
FROM node:18-alpine as Build
WORKDIR /app
COPY ./package.json ./package-lock.json /app/
RUN npm install -g @angular/cli
RUN npm install
COPY . /app

ARG configuration=production
#This will create dist/ and dist-server/ folders in docker
RUN ng build --configuration $configuration
RUN ng run FightCore:server:$configuration

### Stage: 2 ###
FROM node:18-alpine
WORKDIR /app
COPY --from=Build /app/package.json /app
COPY --from=Build /app/dist /app/dist
COPY --from=Build /app/dist/FightCore/server /app/dist-server

EXPOSE 4000

CMD ["npm", "run", "serve:ssr"]
