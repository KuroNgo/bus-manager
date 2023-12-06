import QLXeRepository from "./EntityAPI/QLXeRepository"
import TuyenRepository from "./EntityAPI/TuyenRepository"

const repositories = {
    tuyen: TuyenRepository,
    quanlixe: QLXeRepository,
}

export const RepositoryFactory = {
    get : name => repositories[name]
}