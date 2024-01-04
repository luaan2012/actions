import http from 'k6/http'
import { sleep } from 'k6'

export let options = {
    insecureSkkipTLSVerify: true, 
    noConnectionReuse: false,
    vus: 1,
    duration: '10s'
};

export default () => {
    http.get('https://localhost:7290/GetWeatherForecast');
    sleep(1)
};