import axios from "axios";

const baseDomain = 'https://localhost:7034';
const baseURL = `${baseDomain}/api`;

export default axios.create({
    baseURL,
})